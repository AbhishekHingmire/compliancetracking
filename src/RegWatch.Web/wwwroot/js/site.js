// RegWatch India — site.js

// Initialize Lucide icons on load and after DOM mutations
document.addEventListener('DOMContentLoaded', () => {
    if (typeof lucide !== 'undefined') {
        lucide.createIcons();
    }
});

// Re-init Lucide after Alpine.js renders (for dynamic icons)
document.addEventListener('alpine:initialized', () => {
    if (typeof lucide !== 'undefined') {
        lucide.createIcons();
    }
});

// Keyboard shortcut: Cmd+K / Ctrl+K → focus search
document.addEventListener('keydown', (e) => {
    if ((e.metaKey || e.ctrlKey) && e.key === 'k') {
        e.preventDefault();
        const search = document.querySelector('#search-btn, input[placeholder*="Search"]');
        if (search) {
            search.focus();
            if (search.tagName === 'BUTTON') {
                const input = document.querySelector('input[type="text"][placeholder*="Search"]');
                if (input) input.focus();
            }
        }
    }
});

// Auto-dismiss alert/flash messages after 5 seconds
document.addEventListener('DOMContentLoaded', () => {
    const flashes = document.querySelectorAll('[data-auto-dismiss]');
    flashes.forEach(el => {
        setTimeout(() => {
            el.style.transition = 'opacity 0.4s';
            el.style.opacity = '0';
            setTimeout(() => el.remove(), 400);
        }, 5000);
    });
});
